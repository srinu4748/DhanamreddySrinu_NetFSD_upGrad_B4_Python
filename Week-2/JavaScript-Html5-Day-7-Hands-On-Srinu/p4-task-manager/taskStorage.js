// taskStorage.js

let tasks = []; // Task storage array

// ===============================
// 1️⃣ CALLBACK VERSION
// ===============================

export const addTaskCallback = (task, callback) => {
    setTimeout(() => {
        tasks.push(task);
        callback(`Task "${task}" added (Callback)`);
    }, 1000);
};

export const deleteTaskCallback = (task, callback) => {
    setTimeout(() => {
        tasks = tasks.filter(t => t !== task);
        callback(`Task "${task}" deleted (Callback)`);
    }, 1000);
};

export const listTasksCallback = (callback) => {
    setTimeout(() => {
        callback(`
===== TASK LIST (Callback) =====
${tasks.map((t, i) => `${i + 1}. ${t}`).join("\n")}
================================
`);
    }, 1000);
};


// ===============================
// 2️⃣ PROMISE VERSION
// ===============================

export const addTaskPromise = (task) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks.push(task);
            resolve(`Task "${task}" added (Promise)`);
        }, 1000);
    });
};

export const deleteTaskPromise = (task) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks = tasks.filter(t => t !== task);
            resolve(`Task "${task}" deleted (Promise)`);
        }, 1000);
    });
};

export const listTasksPromise = () => {
    return new Promise((resolve) => {
        setTimeout(() => {
            resolve(`
===== TASK LIST (Promise) =====
${tasks.map((t, i) => `${i + 1}. ${t}`).join("\n")}
===============================
`);
        }, 1000);
    });
};