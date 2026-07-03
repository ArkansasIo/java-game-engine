#pragma once
#include <iostream>
#include "HUDManager.h"

class GalaxyView {
public:
    void SelectObject(const std::string& type, HUDManager& hud) {
        std::cout << "Selected: " << type << ". Updating Command Bar." << std::endl;
        hud.DrawPanel(type + "Panel");
    }
};

void TestSpawn() {
    GalaxyView galaxy;
    HUDManager hud;
    galaxy.SelectObject("Fleet", hud);
    galaxy.SelectObject("Planet", hud);
}