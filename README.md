# Among Us Save Editor.NET

The name says it all,
A simple save editor for Among Us on Windows

  - Change basic settings as your name, color - and even use a glitched color
  - Use any pet/hat/skin without paying
  - Simple GUI, and a more advanced RAW editor for nerds <3

##### OpenSource and free to use and edit :3

# New Features!

+ Status Indicator
+ RAW Editor
+ Graphical Color
+ Named Pets

# Planned Features :D

+ Visual Charector editor (Might take long TwT)
+ Indexed and named hats
+ Visual Pets :O
+ A nicer GUI :p
+ A better name lol
+ Backup button to revert to a hard-coded config if you mess something up.

### Screenshots
[![N|Solid](https://raw.githubusercontent.com/FiskDk/Among-Us-Editor.NET/main/assets/editor1.png?token=AFRI2NPZHF4ZY42CFM33PMS7VVKPW)]()
[![N|Solid](https://raw.githubusercontent.com/FiskDk/Among-Us-Editor.NET/main/assets/editor2.png?token=AFRI2NJUTDC5K53EGH2WUGK7VVKWY)]()

### Installation and usage

All you need is a computer running Windows, and the Among Us game :3
Simply clone or download this project, and run the file 
`Among-Us-Editor.NET\Builds\net5.0-windows\Among Us Editor .NET.exe`

##### How to use it?????

Use the GUI to change the values, as far as i knmow you cant really screw things up, but i still dont take any responsibilites if you screw up lol

##### Im a nerd lol
If you know what you're doing, then you can use the RAW editor, just be careful not to screw everything up.

## Information about Among Us config file ##  
Indexes of playerPrefs file
|Index|Name used by Among Us|Type|Comment|
|--|--|--|--|
|0|lastPlayerName|String||
|1|touchConfig|int|Controls 0 Mouse, 1 Mouse and Keyboard|
|2|colorConfig|uint|0-11, 12+ for Fortegreen ~~glitched~~ color|
|3|ignored unknown||Default `1`|
|4|ignored sendName|bool|Default `False`|
|5|ignored sendTelemetry|bool|Default `False`|
|6|ignored sendDataScreen|bool|Default `False`|
|7|showAdsScreen|bit flags|Personalized `0x00`, NonPersonalized `0x01`, Accepted `0x80`, Purchased `0x82`|
|8|showMinPlayerWarning|bool||
|9|showOnlineHelp|bool||
|10|lastHat|uint|0 to like 93|
|11|sfxVolume|byte|0-255|
|12|musicVolume|byte|0-255|
|13|joyStickSize|float|0.5, 1, 1.5|
|14|lastGameStart|long|Ticks since last game started. Used to check if left game too early|
|15|lastSkin|uint|0-15|
|16|lastPet|uint|0-10|
|17|censorChat|bool||
|18|lastLanguage|uint|0-4, 0: English, 1: Spanish, 2: Portuguese, 3: Korean, 4: Russian|
|19|vsync|bool||

### Have fun <3