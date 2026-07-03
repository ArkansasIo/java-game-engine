#include "src/engine/GameEngine.h"
#include "src/game/MainMenu.h"
#include "src/game/GalaxyView.h"

int main() {
    GameEngine engine;
    engine.Init();
    
    // Test logic
    TestSpawn();
    
    engine.Run();
    return 0;
}