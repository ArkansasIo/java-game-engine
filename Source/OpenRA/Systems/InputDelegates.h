// InputDelegates.h
#pragma once
#include <functional>
#include <string>
#include <map>

// Type definition for command actions
using CommandAction = std::function<void()>;

class InputDispatcher {
private:
    static std::map<std::string, CommandAction> actionMap;

public:
    static void RegisterAction(const std::string& id, CommandAction action) {
        actionMap[id] = action;
    }

    static void Execute(const std::string& id) {
        if (actionMap.count(id)) {
            actionMap[id]();
        }
    }
};
