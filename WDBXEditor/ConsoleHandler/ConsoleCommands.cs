using MySql.Data.MySqlClient;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WDBXEditor.Archives.CASC.Handlers;
using WDBXEditor.Archives.MPQ;
using WDBXEditor.Common;
using WDBXEditor.Reader;
using WDBXEditor.Storage;
using static WDBXEditor.Common.Constants;

namespace WDBXEditor.ConsoleHandler
{
    class ConsoleCommands
    {
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

        #region Load
        /// <summary>
        /// Loads a file into the console
        /// <para>load -f "*.dbc" -s ".mpq/wow dir" -b 11802</para>
        /// </summary>
        /// <param name="args"></param>
        /// 
        public static void LoadCommand(string[] args)
        {
            var pmap = ConsoleManager.ParseCommand(args);
            string file = ParamCheck<string>(pmap, "-f");
            string filename = Path.GetFileName(file);
            string filenoext = Path.GetFileNameWithoutExtension(file);
            string source = ParamCheck<string>(pmap, "-s", false);
            int build = ParamCheck<int>(pmap, "-b");
            SourceType sType = GetSourceType(source);

            //Check file exists if loaded from the filesystem
            if (!File.Exists(file) && sType == SourceType.File)
                throw new Exception($"   File not found {file}.");

            //Check the required definition exists
            var def = Database.Definitions.Tables.FirstOrDefault(x => x.Build == build && x.Name.Equals(filenoext, IGNORECASE));
            if (def == null)
                throw new Exception($"   Could not find definition for {Path.GetFileName(file)} build {build}.");

            Database.BuildNumber = build;
            var dic = new ConcurrentDictionary<string, MemoryStream>();
            string error = string.Empty;

            switch (sType)
            {
                case SourceType.MPQ:
                    Console.WriteLine("Loading from MPQ archive...");
                    using (MpqArchive archive = new MpqArchive(source, FileAccess.Read))
                    {
                        string line = string.Empty;
                        bool loop = true;
                        using (MpqFileStream listfile = archive.OpenFile("(listfile)"))
                        using (StreamReader sr = new StreamReader(listfile))
                        {
                            while ((line = sr.ReadLine()) != null && loop)
                            {
                                if (line.EndsWith(filename, IGNORECASE))
                                {
                                    loop = false;
                                    var ms = new MemoryStream();
                                    archive.OpenFile(line).CopyTo(ms);
                                    dic.TryAdd(filename, ms);

                                    error = Database.LoadFiles(dic).Result.FirstOrDefault();
                                }
                            }
                        }
                    }
                    break;
                case SourceType.CASC:
                    Console.WriteLine("Loading from CASC directory...");
                    using (var casc = new CASCHandler(source))
                    {
                        string fullname = filename;
                        if (!fullname.StartsWith("DBFilesClient", IGNORECASE))
                            fullname = "DBFilesClient\\" + filename; //Ensure we have the current file name structure

                        var stream = casc.ReadFile(fullname);
                        if (stream != null)
                        {
                            dic.TryAdd(filename, stream);

                            error = Database.LoadFiles(dic).Result.FirstOrDefault();
                        }
                    }
                    break;
                default:
                    error = Database.LoadFiles(new string[] { file }).Result.FirstOrDefault();
                    break;
            }

            dic.Clear();

            if (!string.IsNullOrWhiteSpace(error))
                throw new Exception("   " + error);

            if (Database.Entries.Count == 0)
                throw new Exception("   File could not be loaded.");

            Console.WriteLine($"{Path.GetFileName(file)} loaded.");
            Console.WriteLine("");
        }

        public static void ExtractCommand(string[] args)
        {
            var pmap = ConsoleManager.ParseCommand(args);
            string filter = ParamCheck<string>(pmap, "-f", false);
            string source = ParamCheck<string>(pmap, "-s");
            string output = ParamCheck<string>(pmap, "-o");
            SourceType sType = GetSourceType(source);
            
            if (string.IsNullOrWhiteSpace(filter))
                filter = "*";

            string regexfilter = "(" + Regex.Escape(filter).Replace(@"\*", @".*").Replace(@"\?", ".") + ")";
            Func<string, bool> TypeCheck = t => Path.GetExtension(t).ToLower() == ".dbc" || Path.GetExtension(t).ToLower() == ".db2";

            
            var dic = new ConcurrentDictionary<string, MemoryStream>();
            switch (sType)
            {
                case SourceType.MPQ:
                    Console.WriteLine("Loading from MPQ archive...");
                    using (MpqArchive archive = new MpqArchive(source, FileAccess.Read))
                    {
                        string line = string.Empty;
                        using (MpqFileStream listfile = archive.OpenFile("(listfile)"))
                        using (StreamReader sr = new StreamReader(listfile))
                        {
                            while ((line = sr.ReadLine()) != null)
                            {
                                if(TypeCheck(line) && Regex.IsMatch(line, regexfilter, RegexOptions.Compiled | RegexOptions.IgnoreCase))
                                {
                                    var ms = new MemoryStream();
                                    archive.OpenFile(line).CopyTo(ms);
                                    dic.TryAdd(Path.GetFileName(line), ms);
                                }
                            }
                        }
                    }
                    break;
                case SourceType.CASC:
                    Console.WriteLine("Loading from CASC directory...");
                    using (var casc = new CASCHandler(source))
                    {
                        var files = Constants.ClientDBFileNames.Where(x => Regex.IsMatch(Path.GetFileName(x), regexfilter, RegexOptions.Compiled | RegexOptions.IgnoreCase));
                        foreach(var file in files)
                        {
                            var stream = casc.ReadFile(file);
                            if (stream != null)
                                dic.TryAdd(Path.GetFileName(file), stream);
                        }
                    }
                    break;
            }

            if (dic.Count == 0)
                throw new Exception("   No matching files found.");

            if (!Directory.Exists(output))
                Directory.CreateDirectory(output);

            foreach(var d in dic)
            {
                using (var fs = new FileStream(Path.Combine(output, d.Key), FileMode.Create))
                {
                    fs.Write(d.Value.ToArray(), 0, (int)d.Value.Length);
                    fs.Close();
                }
            }

            dic.Clear();

            Console.WriteLine($"   Successfully extracted files.");
            Console.WriteLine("");
        }
        #endregion
        
        #region Export
        /// <summary>
        /// Exports a file to either SQL, JSON or CSV
        /// <para>-export -f "*.dbc" -s ".mpq/wow dir" -b 11802 -o "*.sql|*.csv"</para>
        /// </summary>
        /// <param name="args"></param>
        public static void ExportArgCommand(string[] args)
        {
            var pmap = ConsoleManager.ParseCommand(args);
            string output = ParamCheck<string>(pmap, "-o");
            OutputType oType = GetOutputType(output);

            LoadCommand(args);

            var entry = Database.Entries[0];
            using (FileStream fs = new FileStream(output, FileMode.Create))
            {
                byte[] data = new byte[0];
                switch (oType)
                {
                    case OutputType.CSV:
                        data = Encoding.UTF8.GetBytes(entry.ToCSV());
                        break;
                    case OutputType.JSON:
                        data = Encoding.UTF8.GetBytes(entry.ToJSON());
                        break;
                    case OutputType.SQL:
                        data = Encoding.UTF8.GetBytes(entry.ToSQL());
                        break;
                }

                fs.Write(data, 0, data.Length);

                Console.WriteLine($"Successfully exported to {output}.");
            }
        }

        #endregion
        
        #region SQL Dump
        /// <summary>
        /// Exports a file directly into a SQL database
        /// <para>-sqldump -f "*.dbc" -s ".mpq/wow dir" -b 11802 -c "Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;"</para>
        /// </summary>
        /// <param name="args"></param>
        public static void SqlDumpArgCommand(string[] args)
        {
            var pmap = ConsoleManager.ParseCommand(args);
            string connection = ParamCheck<string>(pmap, "-c");

            LoadCommand(args);

            var entry = Database.Entries[0];
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                }
                catch { throw new Exception("   Incorrect MySQL login details."); }

                entry.ToSQLTable(connection);

                Console.WriteLine($"Successfully exported to {conn.Database}.");
            }
        }

        #endregion

        #region SQL Load
        /// <summary>
        /// Imports a file from a SQL database
        /// <para>-sqlload -f "*.dbc" -b 11802 -c "Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;" -m 0"</para>
        /// </summary>
        /// <param name="args"></param>
        public static void SqlLoadArgCommand(string[] args)
        {
            var pmap = ConsoleManager.ParseCommand(args);

            string connection = ParamCheck<string>(pmap, "-c", false);

            string connection_file = ParamCheck<string>(pmap, "-cf");
            if (connection_file.Length > 0)
                connection = File.ReadAllText(connection_file);

            UpdateMode mode = ParamCheck<UpdateMode>(pmap, "-m");

            LoadCommand(args);

            var entry = Database.Entries[0];

            // @robinsch: ascension build is in fact WotLK
            var buildNumber = entry.Build;
            if (buildNumber == (int)WDBXEditor.Common.Constants.ExpansionFinalBuild.Ascension)
                buildNumber = (int)WDBXEditor.Common.Constants.ExpansionFinalBuild.WotLK;

            // @robinsch: if we have ascension definitions loaded we try to select server side dbc tables
            var table = $"db_{entry.TableStructure.Name.ToLower()}_{buildNumber}";
            if (entry.Build == ((int)WDBXEditor.Common.Constants.ExpansionFinalBuild.Ascension) && AscensionDBCTables.ContainsKey(entry.TableStructure.Name))
                table = AscensionDBCTables[entry.TableStructure.Name];

            string importError = string.Empty;
            if (!entry.ImportSQL(mode, connection, table, out importError))
            {
                var dbcFileName = ParamCheck<string>(pmap, "-f");
                throw new Exception($"   Error importing SQL into {dbcFileName}: {importError}");
            }

            new DBReader().Write(entry, entry.SavePath);
        }

        #endregion  

        #region Helpers
        private static T ParamCheck<T>(Dictionary<string, string> map, string field, bool required = true)
        {
            if (map.ContainsKey(field))
            {
                try
                {
                    if (typeof(T).IsEnum)
                        return (T)Enum.Parse(typeof(T), map[field], true);

                    return (T)Convert.ChangeType(map[field], typeof(T));
                }
                catch
                {
                    if (required) throw new Exception($"   Parameter {field} is invalid");
                }
            }

            if (required)
                throw new Exception($"   Missing parameter '{field}'");

            object defaultval = (typeof(T) == typeof(string) ? (object)string.Empty : (object)0);
            return (T)Convert.ChangeType(defaultval, typeof(T));
        }

        private static SourceType GetSourceType(string source)
        {
            if (string.IsNullOrWhiteSpace(source)) //No source
                return SourceType.File;

            string extension = Path.GetExtension(source).ToLower().TrimStart('.');

            if (File.Exists(source) && extension == "mpq") //MPQ
                return SourceType.MPQ;
            else if (Directory.Exists(source)) //CASC
                return SourceType.CASC;

            throw new Exception($"   Invalid source selected. Options are .MPQ, WoW Directory or blank.");
        }

        private static OutputType GetOutputType(string output)
        {
            string extension = Path.GetExtension(output).ToLower();
            switch (extension)
            {
                case ".csv":
                    return OutputType.CSV;
                case ".sql":
                    return OutputType.SQL;
                case ".json":
                    return OutputType.JSON;
            }

            throw new Exception("   Invalid output type. Options are CSV, JSON or SQL.");
        }


        internal enum SourceType
        {
            File,
            MPQ,
            CASC
        }

        internal enum OutputType
        {
            CSV,
            SQL,
            MPQ,
            JSON
        }
        #endregion
    }
}
