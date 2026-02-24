import {
    addTaskCallback,
    deleteTaskCallback,
    listTasksCallback,
    addTaskPromise,
    deleteTaskPromise,
    listTasksPromise
} from './taskStorage.js';


// ===============================
// 1️⃣ CALLBACK EXECUTION
// ===============================

addTaskCallback("Learn JavaScript", (msg1) => {
    console.log(msg1);

    addTaskCallback("Practice Async", (msg2) => {
        console.log(msg2);

        listTasksCallback((list) => {
            console.log(list);
        });
    });
});


// ===============================
// 2️⃣ PROMISE EXECUTION
// ===============================

addTaskPromise("Build Project")
    .then(msg => {
        console.log(msg);
        return addTaskPromise("Prepare Interview");
    })
    .then(msg => {
        console.log(msg);
        return listTasksPromise();
    })
    .then(list => console.log(list));


// ===============================
// 3️⃣ ASYNC/AWAIT VERSION
// ===============================

const runAsyncVersion = async () => {
    try {
        let msg1 = await addTaskPromise("Apply for Jobs");
        console.log(msg1);

        let msg2 = await deleteTaskPromise("Practice Async");
        console.log(msg2);

        let list = await listTasksPromise();
        console.log(`
===== TASK LIST (Async/Await) =====
${list}
===================================
`);
    } catch (error) {
        console.error("Error:", error);
    }
};

runAsyncVersion();