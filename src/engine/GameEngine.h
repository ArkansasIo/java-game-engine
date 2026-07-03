#pragma once
#include <iostream>
#include <memory>
#include "HUDManager.h"

class GameEngine {
public:
    void Init() {
        std::cout << "Engine Initialized. Graphics and Loop Ready." << std::endl;
        hudManager = std::make_unique<HUDManager>();
    }
    void Run() {
        std::cout << "Starting Game Loop..." << std::endl;
        // Game loop would go here
    }
private:
    std::unique_ptr<HUDManager> hudManager;
};