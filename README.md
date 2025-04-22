# AR-GHAST-FLOATING
FINAL AR PROJECT 10
Here’s a beginner-friendly `README.md` file you can use for your GitHub project featuring a floating **Ghast** controlled with **WASD + Mouse camera**:

---

```markdown
# 👻 Floating Ghast Controller in Unity (WASD + Mouse)

This Unity project features a 3D floating Ghast (or any character you choose), fully controlled using **WASD keys** and **mouse movement**. Perfect for beginner game devs learning character movement and camera controls.

## 🎮 Controls

| Key / Input | Action                    |
|------------|---------------------------|
| `W`        | Move Forward              |
| `S`        | Move Backward             |
| `A`        | Turn Left (Yaw)           |
| `D`        | Turn Right (Yaw)          |
| Mouse Move | Look Around / Orbit Camera |

---

## 🧱 Features

- ✅ Basic Rigidbody-based movement (floating in 3D space)
- ✅ Smooth mouse-controlled orbit camera
- ✅ Easy to customize with any 3D model (like a Ghast or dragon)
- ✅ Unity beginner-friendly setup

   ```
## 📷 Preview

![Floating Ghast Screenshot](https://github.com/SakshamAzad9/AR-GHAST-FLOATING/blob/main/Screenshot%202025-04-22%20230533.png?raw=true)


2. **Open in Unity**
   - Unity version: `2021.3` or newer recommended.
   - Open the project folder via Unity Hub.

3. **Play the Scene**
   - Press `Play` in Unity.
   - Use `WASD` + Mouse to control the floating Ghast.

---

## 🧠 How It Works

- **WASD Movement** is handled with a custom `GhastController.cs` script using Unity's `Rigidbody` for physics-based motion.
- **Mouse Look** is implemented with a `CameraFollow.cs` script that smoothly orbits around the player target.

---

## 📦 Customizing

You can replace the default cube or model with any `.fbx`, `.glb`, or `.obj` file:

1. Drop your 3D model into the `Assets/Models` folder.
2. Drag it into the scene and attach the `GhastController` script.
3. Set the **Main Camera** target to your new model.

---

## 📷 Preview

> *(Include a GIF or screenshot of your floating Ghast in action)*

---

## 📁 Folder Structure

```
Assets/
├── Scripts/
│   ├── GhastController.cs
│   └── CameraFollow.cs
├── Models/
│   └── ghast.fbx
├── Scenes/
│   └── MainScene.unity
```

---

## 🙌 Credits

- 3D Ghast model: [Add your source or credit]
- Made with ❤️ in Unity

---

## 🚀 Next Steps (Suggestions)

- Add floating animation or idle hover motion
- Particle effects (e.g., ghostly trail)
- Skybox or themed environment
- Sound FX when moving

---

```

Let me know if you'd like to include the actual `GhastController.cs` and `CameraFollow.cs` code in the README too!
