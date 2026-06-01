


# Progressive Immersion (PolySpatial)

A walkthrough on setting up a skydome with a slider that controls immersion level in a PolySpatial mixed reality scene.

---

## Part 1 - Scene Setup

1. Create a new folder in Assets called `(Your Name)'s Skydome`
2. Go to the PolySpatial Sample Scenes folder and duplicate (`Cmd + D`) the `MixedReality` scene
3. Rename it `(Your Name)'s Skydome Scene` and move it into your folder
4. In the hierarchy, find the **Instructions** object and delete `Home Button Text and Icon`
5. **Delete both `XR Origin` and `AR Session` from the hierarchy** or the scene will look broken on the AVP

---

## Part 2 - Adding the Skybox

1. In the Assets search bar, find `CutSphere`, duplicate it, and add it to your folder
2. Open your Skydome scene and drag the CutSphere into the hierarchy
3. Right click the CutSphere in the hierarchy -> **Prefab -> Unpack Completely**
4. Rename it something like `Sky`

> Unpacking lets you swap out the skybox image later without modifying the original prefab in Assets.

5. Select your `Sky` object in the hierarchy, then go to **Skybox (material) -> Surface Options**
   - Set **Surface Type** to `Transparent`
   - Set **Blending Mode** to `Alpha`

> Always make changes to the skybox through the hierarchy, not the Assets folder.

### Adding Your Own Sky Image (Optional)

1. Add an image to your folder
2. In your `Sky` object in the hierarchy, drag the image onto the square next to **Base Map**

---

## Part 3 - Adding the UI

1. Open the PolySpatial sample scene `SpatialUI`
2. Drag the **`Manager`** and **`SpatialPanel_UI`** objects from the hierarchy into your Skydome folder

> It helps to have your Skydome folder open at the same time so you can drag and drop easily.

3. Open your Skydome scene and add `Manager` and `SpatialPanel_UI` to the hierarchy
4. Double click `SpatialPanel_UI` and delete everything inside it except for the **slider**
5. Set the `SpatialPanel_UI` transform position to `0, 0, 0` (or move it manually to sit near the Instructions panel)
6. In the hierarchy, drag `SpatialPanel_UI` onto the **Instructions** object to make it a child of it
7. Reposition `SpatialPanel_UI` so it sits nicely on the instructions panel

> You may need to move the entire Instructions object up slightly depending on how it looks in the Simulator.

### Updating the Instruction Text

1. In the hierarchy go to **Instructions -> Instructions**
2. For both `title` and `description`, find the TextMeshPro text object and update the text:
   - Title: `Progressive Immersion`
   - Description: `Drag the slider to change immersion level`

> Tip: Hold `Option` in the scene view to pan around easily.

---

## Part 4 - Sky Opacity Controller

This script reads the slider value and uses it to control the opacity of the sky sphere.

### 1. Create the controller object

Right click in the hierarchy -> **Create Empty** -> name it `SkyOpacityController`

### 2. Add the script

Add a new script called `SkyOpacityController` and add the script provided to you in the repo.


### 3. Assign the references

After adding the script, you need to assign both fields in the Inspector:

- **Slider Fill Renderer**: drag in `SliderImage`, found at `Instructions -> SpatialPanel_UI -> SliderBackdrop -> SliderImage`
- **Sky Sphere Renderer**: drag in your `Sky` object from the hierarchy

---

## Hierarchy Check

Before testing, make sure your hierarchy looks something like this:

```
Instructions
    SpatialPanel_UI
        SliderBackdrop
            SliderImage
Sky
SkyOpacityController
Manager
```
