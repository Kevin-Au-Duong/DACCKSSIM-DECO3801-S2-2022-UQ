# RUSH-DECO3801
An interactive software (game but not really) that will make Aussies become safer drivers. Guarantee to decrease the nation's traffic fatality rate to absolute 0, or even negative. It's so good it'll bring the dead back to life.

## 🔧 Setting up Local Development (Simulation)

Required:

- [Unity Editor v2022.1.14f](https://unity3d.com/get-unity/download/archive)

```bash
$ git clone https://github.com/Kevin-Au-Duong/RUSH-DECO3801/simulation.git
```

To run in Unity:

- Open Unity
- Go to `File` and `Open Project...`
- Navigate to where you cloned the simulation, click on the `simulation` directory then `Open`
- In the `Project` window, open up the `Assets` folder and go to `Scenes`
- Drag the `CityDrive` scene on to the main `Hierarchy` window

## 🔨 Building the .APK (Simulation)

Once you have opened the project:

- Go to `File` and `Build Settings...`
- In the `Platform` window, select `Android` but [if Android is greyed out you must install some dependencies first](https://docs.unity3d.com/2022.1/Documentation/Manual/android-sdksetup.html)
- Click `Build` and select the destination for where you would like the APK to be saved
- Click `Save` and wait

Now you have an .APK file which you can run on an Android device/emulator!

__*Note that the .APK file will only run on Android systems that are using ARMv7 CPU architecture or support ARMv7 .APK files.*__
