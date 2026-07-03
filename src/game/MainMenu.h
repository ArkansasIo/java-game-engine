#pragma once
#include <iostream>
#include "HUDManager.h"

class MainMenu {
public:
    void ClickNewGame(HUDManager& hud) {
        std::cout << "Switching to Galaxy View." << std::endl;
        hud.DrawPanel("GalaxyView");
    }
};