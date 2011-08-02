// This file contains all global variables used throughout the system
//
// -*-*-Key-*-*-
// tmp<var> - Temporary variables (These are used over and over again)
// gbl<var> - Long term variables (These will change every now and then)
// -*-*-*-*-*-*-
//
// MoonPunch Minecraft Server was created by MoonPunch and his trusty side kick
// Microsoft Visual C# 2010 Express, his beautiful computer and of course - Tea & Coffee.

using System.Net;
using System;
using System.ComponentModel;
using System.Windows.Forms;

public static class GlobalVar
{
    // Constants
    public const string BukkitDownload = "http://ci.bukkit.org/job/dev-CraftBukkit/1000/artifact/target/craftbukkit-0.0.1-SNAPSHOT.jar";
    public const string OfficialDownload = "http://www.minecraft.net/download/minecraft_server.jar";
    public const string javaLocation = @"""%ProgramFiles%\Java\jre6\bin\java.exe""";
    public const string bukkitFileName   = "bukkit0.0.1.jar";
    public const string officialFileName = "minecraft_server.jar";
    public const string batchFileName = @"\server_start.bat";

    // Long Term variables
    public static string cleanDir;
    public static string batchOut;

    // Temporary
    public static string tmpServerLink    = "";  // Stores the link to the server before conversion
    public static string tmpInstallDir    = "";  // stores the link to the server after conversion

    // Methods

}
