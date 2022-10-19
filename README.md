# 📷 DACCKSSIM
An interactive software made in Unity that acts as the backend for the [DACCKSCAM](https://github.com/Kevin-Au-Duong/DACCKSCAM-DECO3801-S2-2022-UQ) application.

## 🔧 Setting up Local Development (Simulation)

Required:

- [Unity Editor v2022.1.14f](https://unity3d.com/get-unity/download/archive)
- [Git](https://git-scm.com/downloads)

```bash
$ git clone https://github.com/Kevin-Au-Duong/DACCKSSIM-DECO3801-S2-2022-UQ/simulation.git
```

Assets used:

- [Standard Assets (for Unity 2018.4)](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2018-4-32351)
- [Edy's Vehicle Physics](https://assetstore.unity.com/packages/tools/physics/edy-s-vehicle-physics-403)
- [Vehicle Physics Pro - Community Edition](https://assetstore.unity.com/packages/tools/physics/vehicle-physics-pro-community-edition-153556)
- [Australian Street Sign Pack](https://assetstore.unity.com/packages/3d/environments/urban/australian-street-sign-pack-213047)
- [FREE Traffic Essentials Asset Pack](https://assetstore.unity.com/packages/3d/props/free-traffic-essentials-asset-pack-125092)

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
- Change relevant settings in `Player Settings...` if required
- Click `Build` and select the destination for where you would like the APK to be saved
- Click `Save` and wait

Now you have an .APK file which you can run on an Android device/emulator!

__*Note that the .APK file will only run on Android systems that are using ARMv7 CPU architecture or support ARMv7 .APK files.*__
