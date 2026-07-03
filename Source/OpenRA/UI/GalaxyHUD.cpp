#include "UI/UIBase.h"
#include <vector>
#include <string>
#include <iostream>

class GalaxyHUD {
public:
    void Init() {
        std::cout << "GalaxyHUD: Initializing Stellaris-style layout..." << std::endl;
        layers = {"hyperlanes", "sensor_coverage", "border_influence"};
    }

    void Render() {
        DrawTopBar();
        DrawOutliner();
        DrawCommandBar();
        DrawGalaxyOverlay();
    }

private:
    std::vector<std::string> layers;

    void DrawTopBar() {
        std::cout << "[UI] Rendering Top Bar (Blue Theme, #050A0F)..." << std::endl;
    }

    void DrawOutliner() {
        std::cout << "[UI] Rendering Right-Side Outliner..." << std::endl;
    }

    void DrawCommandBar() {
        std::cout << "[UI] Rendering Bottom HUD (Context-Sensitive)..." << std::endl;
    }

    void DrawGalaxyOverlay() {
        std::cout << "[UI] Rendering Galaxy Map Layers:" << std::endl;
        for (const auto& layer : layers) {
            std::cout << "  - " << layer << " [ACTIVE]" << std::endl;
        }
    }
};
