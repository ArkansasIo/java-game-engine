# Space OGame Asset Generation Guide
To maintain the "Blue Theme" consistency for your icons and UI elements, follow these specs.

## 1. Icon Style Specification (SVG/PNG)
*   **Color Palette:** Use the defined `#00A3FF` (Primary Blue) and `#40E0FF` (Accent Glow).
*   **Style:** Minimalist, geometric, flat vector-style. Avoid excessive shading; use subtle inner glows to imply "high-tech" activity.
*   **Resolution:** 64x64px for Command Bar; 32x32px for Lists/Outliners.

## 2. Mandatory Icon Set (Requirement: Blue/Cyan)
1.  **Commands:**
    *   `move.png`: Upward-pointing navigation arrow.
    *   `attack.png`: Crossed swords or targeting reticle.
    *   `patrol.png`: Circular infinity loop.
    *   `formation.png`: A grid of 4 squares representing unit grouping.
2.  **Empire/Planet:**
    *   `build.png`: Wrench and hammer icon.
    *   `terra.png`: Globe with a thermometer/gauge.
    *   `tax.png`: Currency symbol ($/Cr) inside a box.

## 3. UI Asset Generation (Material/Texture)
*   **BlueGlass_Panel.png:** A texture file containing a slight grainy noise overlay with transparency gradients (15-25% opacity) for use in your Unreal Material.
*   **Border_Glow.png:** A 2px wide border sprite with a soft blue neon glow (alpha-masked) for use on all active selection panels.
*   **Galaxy_Background.png:** Deep space texture (Hex: #050A0F) with procedural starfield sprites (varying sizes of #E0F0FF).

## 4. Suggested Creation Workflow
1.  **Vector Editor:** Use Inkscape or Illustrator to create the icons in white.
2.  **Export:** Export as 32-bit PNG with transparency.
3.  **Engine Import:** Import into Unreal's `Content/UI/Icons` folder.
4.  **Material Creation:** Create a "UI Material" with the "Translucent" blend mode, applying the texture as an `Emissive` source using the `#00A3FF` tint.
