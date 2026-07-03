#pragma once
#include <vector>
#include <cstring>
#include <iostream>

struct StateBuffer {
    std::vector<uint8_t> data;
};

class NetworkSync {
public:
    static StateBuffer SerializeState(float energy, int population) {
        StateBuffer buffer;
        size_t size = sizeof(float) + sizeof(int);
        buffer.data.resize(size);
        
        uint8_t* ptr = buffer.data.data();
        std::memcpy(ptr, &energy, sizeof(float));
        ptr += sizeof(float);
        std::memcpy(ptr, &population, sizeof(int));
        
        return buffer;
    }

    static void DeserializeState(const StateBuffer& buffer) {
        if (buffer.data.size() < sizeof(float) + sizeof(int)) return;
        
        float energy;
        int population;
        
        const uint8_t* ptr = buffer.data.data();
        std::memcpy(&energy, ptr, sizeof(float));
        ptr += sizeof(float);
        std::memcpy(&population, ptr, sizeof(int));
        
        std::cout << "Deserialized State: Energy=" << energy << " Pop=" << population << std::endl;
    }
};
