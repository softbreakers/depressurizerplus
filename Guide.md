## Introduction ##

Depressurizer+ is a program that will allow you to much more easily categorize games within large libraries, giving you an alternative to the current Steam client interface.

## Requirements ##

  * Windows platform with .NET 4.0 and a Steam installation

  * A working internet connection

  * A Steam Community Profile that's set to be public

**Important:** In order to use the program effectively, you must first make sure that your Steam Community Profile has been set up, and that your profile is set to "Public." Otherwise, the program will have no way to access a list of your games.

## Before You Begin ##

No special installation steps are necessary. Just unpack the archive anywhere on your hard drive. To run the program, just run Depressurizer+.exe.

**Note:** For some setups, it may be a good idea to run the program as an administrator. This will be required for optimal use if you are running under a user account that does not have write access to the Steam installation directory. You can set the executable to always run as admin in the file Properties dialog under the Compatibility tab.

## Basic Use Guide ##

Before you begin, make sure that Steam is not running. At the least, you will have to shut down Steam before you save.

  1. After starting the program for the first time, it will ask you for the path to Steam. Confirm that the suggested path is correct, or enter the path manually, and click OK.
  1. On first run, the program will prompt you to create a profile. It will show you a list of accounts with settings saved in your Steam installation. Yours should be here; select it.
  1. Click the OK button, and the program will create your profile file, and also download a list of all your games and import any existing category information from Steam.
  1. You can auto-categorize games by selecting them and clicking the "Auto-Categorize" button in the lower right corner of the window. Category information is extracted from Steam store and saved into a database. If "Auto-Categorize" does not work but you can access Steam store web page for that game, then perhaps your database is outdated.
  1. Games database can be updated from "Database Editor" window, inside "Tools" menu. First update game list by clicking on "Fetch List" button, to download new games added to Steam store. Then click "Update New" to extract information of new games from Steam store. You can manage entire database by adding, deleting and editing database entries.
  1. You can also manually edit categories and move your games around. Selecting a category in the list on the left will filter your view to games in that category. Create new categories by clicking the "add" button under the category list, or by Selecting 'Add new...' in the lower right dropdown then clicking "Set Category" (this method will also assign all selected games to the new category). Games can be categorized by dragging them to the category list or using the dropdown in the lower right.
  1. When you are done, make sure Steam is not running. Click on File > Save Profile, and you're done. The program should automatically export your category info back to Steam. Load Steam up again to make sure everything worked okay.
  1. Depressurizer+ is backward compatible with Depressurizer 0.4.4, so if you have previously used Depressurizer, Depressurizer+ will load previous profiles and settings.

If you want to make further changes later, or if you want to categorize new games, or if Steam eats your categories and you need to re-set them, just run the program again. If you left all the settings at their default values, the program will automatically load up your previously set categories and download an updated game list (this may take a few moments). You can then edit and/or save again as desired.

Depressurizer+ includes support for external games added to Steam library by Steam client functionality "Add a Non-Steam Game...". Auto-categorize for external games is disabled, although you can categorize them manually. Only external games which have been launched at least once by Steam client will be loaded by Depressurizer+. This functionality can be disabled for each profile from "Edit Profile Info" window, "Ignored Games" tab.

Depressurizer+ includes multilanguage support. At 1.0.0 version, Depressurizer+ only supports english and spanish. By default Depressurizer+ language is fixed by operative system settings. If operative system language is spanish, Depressurizer+ starts in spanish, otherwise it starts in english. Default behaviour can be overwritten from "Settings" windows, inside "Tools" menu. Note that changing language settings don't translate your category names.

## On terminology ##

  * Load / Save: This always refers to loading and saving profiles, which contain a few settings as well as a complete list of your games and the associated category information. This is not a Steam configuration file, and Steam cannot see these.

  * Import: This means the program checks your Steam config file and loads up all the categories from it.

  * Export: The program writes all your category data to Steam so that you can see it in the Steam client

  * Download: The program grabs your game list from the community site. This is the only way for the program to get a list of your games.

## Known Issues and Caveats ##

This is a work in progress.

Some games will not show up in the program. This is a result of the games not showing up on your community profile page. Likewise, there are also many "games" that show up in the program but do _not_ show up in the actual Steam client (mostly DLC packs). Ignoring or loading of DLC packs is for each profile from "Edit Profile Info" window, "Ignored Games" tab.