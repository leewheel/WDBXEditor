using WDBXEditor.Storage;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WDBXEditor.Common.Constants;

namespace WDBXEditor
{
    public partial class LoadSQL : Form
    {
        public string ConnectionString => $"Server={txtHost.Text};Port={txtPort.Text};Database={ddlDatabases.Text};Uid={txtUser.Text};Pwd={txtPass.Text};";
        public bool ConnectionOnly { get; set; } = false;
        public DBEntry Entry { get; set; }
        public string ErrorMessage = string.Empty;

        private bool testedconnection = false;

        private Dictionary<String, String> AscensionDBCTables = new Dictionary<String, String>(StringComparer.OrdinalIgnoreCase) {
            {  "Achievement",           "dbc_achievement" },
            {  "Achievement_Criteria",  "dbc_achievement_criteria" },
            {  "AreaTable",             "dbc_area_table" },
            {  "CreatureFamily",        "dbc_creature_family" },
            {  "CreatureType",          "dbc_creature_type" },
            {  "CurrencyCategory",      "dbc_currency_category" },
            {  "CurrencyTypes",         "dbc_currency_types" },
            {  "DungeonEncounter",      "dbc_dungeon_encounter" },
            {  "Faction",               "dbc_faction" },
            {  "FactionTemplate",       "dbc_faction_template" },
            {  "Holidays",              "dbc_holidays" },
            {  "ItemExtendedCost",      "dbc_item_extended_cost" },
            {  "LFGDungeons",           "dbc_lfg_dungeons" },
            {  "Lock",                  "dbc_lock" },
            {  "Map",                   "dbc_map" },
            {  "MapDifficulty",         "dbc_map_difficulty" },
            {  "PvpDifficulty",         "dbc_pvp_difficulty" },
            {  "SkillLine",             "dbc_skill_line" },
            {  "Spell",                 "spell" },
            {  "SpellItemEnchantment",  "dbc_spell_item_enchantment" },
            {  "SpellShapeshiftForm",   "dbc_spell_shapeshift_form" },
            {  "SpellIcon",             "dbc_spellicon" },
            {  "SpellVisual",           "dbc_spellvisual" },
            {  "Talent",                "dbc_talent" },
            {  "TalentTab",             "dbc_talent_tab" },
            {  "WorldSafeLocs",         "dbc_world_safe_locs" },
        };

        public LoadSQL()
        {
            InitializeComponent();
        }

        private void LoadSQL_Load(object sender, EventArgs e)
        {
            if (ConnectionOnly)
            {
                ddlTable.Enabled = false;
                radNewOnly.Enabled = false;
                radOverride.Enabled = false;
                radUpdate.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                btnLoad.Text = "Export";
                ddlDatabases.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            if (LoadSettings())
            {
                // load databases
                btnRefresh_Click(null, new EventArgs());

                // try to select database from settings
                LoadDatabase();

                // @robinsch: if we have ascension definitions loaded we try to select server side dbc tables
                if (Entry.Build == ((int)WDBXEditor.Common.Constants.ExpansionFinalBuild.Ascension) && AscensionDBCTables.ContainsKey(Entry.TableStructure.Name))
                {
                    int i = ddlTable.FindStringExact(AscensionDBCTables[Entry.TableStructure.Name]);
                    if (i != -1)
                        ddlTable.SelectedIndex = i;
                }
                else
                {
                    // try to select table from current dbc
                    int index = ddlTable.FindStringExact($"db_{Entry.TableStructure.Name.ToLower()}_{Entry.Build}");
                    if (index != -1)
                        ddlTable.SelectedIndex = index;
                }
            }
        }

        #region Buttons
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ddlDatabases.Items.Clear();
            testedconnection = false;
            ddlDatabases.Enabled = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SHOW DATABASES;", connection);
                    using (var rdr = command.ExecuteReader())
                    {
                        ddlDatabases.Items.Add("");

                        while (rdr.Read())
                            ddlDatabases.Items.Add(rdr[0].ToString());

                        testedconnection = true;
                        ddlDatabases.Enabled = true;
                        SaveSettings();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!ConnectionOnly)
            {
                ((Main)this.Owner).ProgressBarHandle(true, "Importing SQL...");
                this.Enabled = false;

                string table = ddlTable.Text;
                string constring = ConnectionString;

                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        UpdateMode mode = UpdateMode.Insert;
                        if (radUpdate.Checked)
                            mode = UpdateMode.Update;
                        else if (radOverride.Checked)
                            mode = UpdateMode.Replace;

                        if (Entry.ImportSQL(mode, constring, table, out ErrorMessage))
                            return DialogResult.OK;
                        else
                            return DialogResult.Abort;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        return DialogResult.Abort;
                    }

                })
				.ContinueWith(x =>
                {
                    this.Enabled = true;
                    this.DialogResult = x.Result;
                    this.Close();
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        #endregion

        #region Dropdown Methods
        private void ddlDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTable.Enabled)
            {
                ddlTable.Items.Clear();

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand($"USE {ddlDatabases.Text}; SHOW TABLES;", connection);
                        using (var rdr = command.ExecuteReader())
                        {
                            ddlTable.Items.Add("");
                            while (rdr.Read())
                                ddlTable.Items.Add(rdr[0].ToString());
                        }
                    }
                }
                catch { return; }
            }

            btnLoad.Enabled = !string.IsNullOrWhiteSpace(ddlDatabases.Text) && //Database selected
                              testedconnection && //Connection works
                              (!string.IsNullOrWhiteSpace(ddlTable.Text) || !ddlTable.Enabled); //Table selected/not applicable

            if (!string.IsNullOrWhiteSpace(ddlDatabases.Text)) //Database selected
                SaveDatabase();
        }

        private void ddlTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLoad.Enabled = !string.IsNullOrWhiteSpace(ddlDatabases.Text) && //Database selected
                             testedconnection && //Connection works
                             (!string.IsNullOrWhiteSpace(ddlTable.Text) || !ddlTable.Enabled); //Table selected/not applicable
        }
        #endregion

        private void SaveSettings()
        {
            Properties.Settings.Default["Host"] = txtHost.Text;
            Properties.Settings.Default["Port"] = txtPort.Text;
            Properties.Settings.Default["User"] = txtUser.Text;
            Properties.Settings.Default["Password"] = txtPass.Text;
            Properties.Settings.Default.Save();
        }

        private bool LoadSettings()
        {
            txtHost.Text = Properties.Settings.Default["Host"].ToString();
            txtPort.Text = Properties.Settings.Default["Port"].ToString();
            txtUser.Text = Properties.Settings.Default["User"].ToString();
            txtPass.Text = Properties.Settings.Default["Password"].ToString();

            return txtHost.Text.Length > 0 && txtPort.Text.Length > 0 && txtUser.Text.Length > 0 && txtPass.Text.Length > 0;
        }

        private void SaveDatabase()
        {
            Properties.Settings.Default["Database"] = ddlDatabases.Text;
            Properties.Settings.Default.Save();
        }

        private bool LoadDatabase()
        {
            string database = Properties.Settings.Default["Database"].ToString();
            int index = ddlDatabases.FindStringExact(database);
            if (index == -1)
                return false;

            ddlDatabases.SelectedIndex = index;
            return true;
        }

    }
}
