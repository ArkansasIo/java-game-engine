# Arklight Graphics Strategy: SDL3 + Vulkan Integration

## Overview
Transitioning from aging OpenGL to a modern SDL3 + Vulkan backend to support the demanding requirements of *UniversCivilization: Empire at War*.

## Core Architecture
- **SDL3 (Low-Level Management):** Handles window creation, input management, OS events, and thread pooling.
- **Vulkan (Rendering API):** Direct control over GPU pipelines, command buffers, and memory management to achieve high-performance rendering for thousands of space entities (units, fleets, planetary structures).

## Strategic Benefits
- **Cross-Platform:** Native support across Windows, Linux, and macOS (via MoltenVK).
- **Efficiency:** Drastic reduction in CPU overhead compared to OpenGL by moving draw call submission to worker threads and utilizing bindless resources.
- **Scalability:** Optimized for the 4X/RTS/MMORPG scale, allowing for complex shaders (atmospheric effects, warp jumps) and instanced rendering of massive fleets.

## Implementation Path
1. **Abstraction Layer:** Develop a RenderDevice interface to decouple gameplay logic from the backend.
2. **Resource Management:** Implement custom Vulkan memory allocators.
3. **Pipeline System:** Utilize precompiled SPIR-V shaders to minimize hitching.
