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

        private static Dictionary<String, String> AscensionDBCTables = new Dictionary<String, String>(StringComparer.OrdinalIgnoreCase)
        {
            { "Achievement", "dbc_achievement" },
            { "Achievement_Category", "dbc_achievement_category" },
            { "Achievement_Criteria", "dbc_achievement_criteria" },
            { "AreaGroup", "dbc_area_group" },
            { "AreaPoi", "dbc_area_poi" },
            { "AreaTable", "dbc_area_table" },
            { "AreaTrigger", "dbc_area_trigger" },
            { "BattlemasterList", "dbc_battlemaster_list" },
            { "CameraShakes", "dbc_camera_shakes" },
            { "CharStartOutfit", "dbc_char_start_outfit" },
            { "ChrClasses", "dbc_chr_classes" },
            { "CreatureDisplayInfo", "dbc_creature_display_info" },
            { "CreatureDisplayInfoExtra", "dbc_creature_display_info_extra" },
            { "CreatureFamily", "dbc_creature_family" },
            { "CreatureModelData", "dbc_creature_model_data" },
            { "CreatureMovementInfo", "dbc_creature_movement_info" },
            { "CreatureSoundData", "dbc_creature_sound_data" },
            { "CreatureSpellData", "dbc_creature_spell_data" },
            { "CreatureType", "dbc_creature_type" },
            { "CurrencyCategory", "dbc_currency_category" },
            { "CurrencyTypes", "dbc_currency_types" },
            { "DungeonEncounter", "dbc_dungeon_encounter" },
            { "DungeonMap", "dbc_dungeon_map" },
            { "DungeonMapChunk", "dbc_dungeon_map_chunk" },
            { "Faction", "dbc_faction" },
            { "FactionGroup", "dbc_faction_group" },
            { "FactionTemplate", "dbc_faction_template" },
            { "GameObjectDisplayInfo", "dbc_gameobject_display_info" },
            { "GroundEffectDoodad", "dbc_ground_effect_doodad" },
            { "GroundEffectTexture", "dbc_ground_effect_texture" },
            { "HelmetGeosetVisData", "dbc_helmet_geoset_vis_data" },
            { "Holidays", "dbc_holidays" },
            { "ItemCondExtCosts", "dbc_item_cond_ext_costs" },
            { "ItemDisplayInfo", "dbc_item_display_info" },
            { "ItemExtendedCost", "dbc_item_extended_cost" },
            { "ItemLimitCategory", "dbc_item_limit_category" },
            { "ItemPurchaseGroup", "dbc_item_purchase_group" },
            { "ItemRandomProperties", "dbc_item_random_properties" },
            { "ItemRandomSuffix", "dbc_item_random_suffix" },
            { "ItemSet", "dbc_item_set" },
            { "ItemVisualEffects", "dbc_item_visual_effects" },
            { "ItemVisuals", "dbc_item_visuals" },
            { "LfgDungeonExpansion", "dbc_lfg_dungeon_expansion" },
            { "LfgDungeonGroup", "dbc_lfg_dungeon_group" },
            { "LfgDungeons", "dbc_lfg_dungeons" },
            { "Lock", "dbc_lock" },
            { "LockType", "dbc_lock_type" },
            { "NpcSounds", "dbc_npc_sounds" },
            { "ObjectEffect", "dbc_object_effect" },
            { "ObjectEffectGroup", "dbc_object_effect_group" },
            { "ObjectEffectModifier", "dbc_object_effect_modifier" },
            { "ObjectEffectPackage", "dbc_object_effect_package" },
            { "ObjectEffectPackageElem", "dbc_object_effect_package_elem" },
            { "OverrideSpellData", "dbc_override_spell_data" },
            { "ParticleColor", "dbc_particle_color" },
            { "PvpDifficulty", "dbc_pvp_difficulty" },
            { "QuestFactionReward", "dbc_quest_faction_reward" },
            { "QuestInfo", "dbc_quest_info" },
            { "QuestSort", "dbc_quest_sort" },
            { "QuestXp", "dbc_quest_xp" },
            { "RandPropPoints", "dbc_rand_prop_points" },
            { "ScalingStatDistribution", "dbc_scaling_stat_distribution" },
            { "ScalingStatValues", "dbc_scaling_stat_values" },
            { "ScreenEffect", "dbc_screen_effect" },
            { "SheatheSoundLookups", "dbc_sheathe_sound_lookups" },
            { "SkillCostsData", "dbc_skill_costs_data" },
            { "SkillLine", "dbc_skill_line" },
            { "SkillLineAbilityPlayerPatch", "dbc_skill_line_ability_player_patch" },
            { "SkillLineCategory", "dbc_skill_line_category" },
            { "SkillRaceClassInfo", "dbc_skill_race_class_info" },
            { "SkillTiers", "dbc_skill_tiers" },
            { "SoundAmbience", "dbc_sound_ambience" },
            { "SoundEmitters", "dbc_sound_emitters" },
            { "SoundEntries", "dbc_sound_entries" },
            { "SoundEntriesAdvanced", "dbc_sound_entries_advanced" },
            { "SoundFilter", "dbc_sound_filter" },
            { "SoundFilterElem", "dbc_sound_filter_elem" },
            { "SoundProviderPreferences", "dbc_sound_provider_preferences" },
            { "SoundSamplePreferences", "dbc_sound_sample_preferences" },
            { "SoundWaterType", "dbc_sound_water_type" },
            { "Spell", "spell_player_patch" },
            { "SpellCastTimes", "dbc_spell_cast_times" },
            { "SpellCategory", "dbc_spell_category" },
            { "SpellChainEffects", "dbc_spell_chain_effects" },
            { "SpellDescriptionVariables", "dbc_spell_description_variables" },
            { "SpellDifficulty", "dbc_spell_difficulty" },
            { "SpellDuration", "dbc_spell_duration" },
            { "SpellEffectCameraShakes", "dbc_spell_effect_camera_shakes" },
            { "SpellFocusObject", "dbc_spell_focus_object" },
            { "SpellItemEnchantment", "dbc_spell_item_enchantment" },
            { "SpellItemEnchantmentCondition", "dbc_spell_item_enchantment_condition" },
            { "SpellMissile", "dbc_spell_missile" },
            { "SpellMissileMotion", "dbc_spell_missile_motion" },
            { "SpellRadius", "dbc_spell_radius" },
            { "SpellRange", "dbc_spell_range" },
            { "SpellRuneCost", "dbc_spell_rune_cost" },
            { "SpellShapeshiftForm", "dbc_spell_shapeshift_form" },
            { "SpellVisualEffectName", "dbc_spell_visual_effect_name" },
            { "SpellVisualKit", "dbc_spell_visual_kit" },
            { "SpellVisualKitAreaModel", "dbc_spell_visual_kit_area_model" },
            { "SpellVisualKitModelAttach", "dbc_spell_visual_kit_model_attach" },
            { "SpellVisualPrecastTransitions", "dbc_spell_visual_precast_transitions" },
            { "SpellIcon", "dbc_spellicon" },
            { "SpellVisual", "dbc_spellvisual" },
            { "Talent", "dbc_talent" },
            { "TalentTab", "dbc_talent_tab" },
            { "TaxiNodes", "dbc_taxi_nodes" },
            { "TaxiPath", "dbc_taxi_path" },
            { "TaxiPathNode", "dbc_taxi_path_node" },
            { "TotemCategory", "dbc_totem_category" },
            { "TransportAnimation", "dbc_transport_animation" },
            { "TransportPhysics", "dbc_transport_physics" },
            { "TransportRotation", "dbc_transport_rotation" },
            { "UiSoundLookups", "dbc_ui_sound_lookups" },
            { "UnitBlood", "dbc_unit_blood" },
            { "UnitBloodLevels", "dbc_unit_blood_levels" },
            { "Vehicle", "dbc_vehicle" },
            { "VehicleSeat", "dbc_vehicle_seat" },
            { "VehicleUiIndSeat", "dbc_vehicle_ui_ind_seat" },
            { "VehicleUiIndicator", "dbc_vehicle_ui_indicator" },
            { "VocalUiSounds", "dbc_vocal_ui_sounds" },
            { "WorldChunkSounds", "dbc_world_chunk_sounds" },
            { "WorldMapArea", "dbc_world_map_area" },
            { "WorldMapContinent", "dbc_world_map_continent" },
            { "WorldMapOverlay", "dbc_world_map_overlay" },
            { "WorldMapTransforms", "dbc_world_map_transforms" },
            { "WorldSafeLocs", "dbc_world_safe_locs" },
            { "WorldStateUi", "dbc_world_state_ui" },
            { "WorldStateZoneSounds", "dbc_world_state_zone_sounds" },
            { "ZoneIntroMusicTable", "dbc_zone_intro_music_table" },
            { "ZoneMusic", "dbc_zone_music" }
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
            catch (System.TimeoutException ex)
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
