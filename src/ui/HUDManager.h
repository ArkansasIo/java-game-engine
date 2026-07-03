#pragma once
#include <iostream>
#include <string>

class HUDManager {
public:
    void DrawPanel(const std::string& panelName) {
        std::cout << "Drawing panel " << panelName << " using Blue Theme." << std::endl;
    }
};