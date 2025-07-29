# VR Zoo (Unity 2021 + XR Interaction Toolkit)

> **Work‑in‑Progress ⚠️**  
> This repository documents an ongoing personal learning project built with Unity 2021 LTS and the XR Interaction Toolkit.
> The goal is to create an interactive virtual zoo that players can explore after leaving their own in‑game bedroom.

## Current State DEMO
https://drive.google.com/file/d/19kl1IOHL3tO8OlEHeq10Xm48KFDxy662/view?usp=sharing 

---

## 1  Current Playable Features

### Grabbable Objects  
The scene contains basic props configured as **XR Grab Interactables** (complete with physics and haptic feedback where supported).  
These items let new VR users practice picking up and manipulating objects before engaging with the animals or the drawing area.

### Free‑Form Drawing Zone  
Inside the park is a dedicated **Drawing Corner**.  When the player’s XR Origin enters the trigger volume, the hand controllers switch to “Brush” mode:  
* 3‑D line strokes are emitted in real time using a Line Renderer.  
* Both hands can draw independently; stroke colour and width are tweakable.  
* Leaving the area automatically disables brush mode so the rest of the zoo is unaffected.

### Animated Animals (First Pass)  
A collection of low‑poly animals—elephant, hippo, tiger, bear, zebra, deer and more are present in the scene and already play idle/walk animations on a loop.  
They are not yet placed in final habitats; pens and signage will come in the next milestone.

---

## 2  Roadmap

1. **Zoo Layout & Enclosures**  
   * Snap‑together fence modules and mesh gates for each species.  
   * Information boards that display fun facts when the player points at them.

2. **Home / Room Hub**  
   * Players will spawn inside a personalised bedroom.  
   * Interacting with key objects (e.g., door handle, map, backpack) opens the teleportation portal to the zoo.
   * Swappable skins for the bed/sofa and so on.

3. **Enhanced Drawing Corner**  
   * Replace the plain trigger cube with a themed pavilion.  
   * Add a colour‑picker palette, eraser tool and “Save Sketch” screenshot button.

---
