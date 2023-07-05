<template>
    <div class="page">

        <div class="row align-center space-between">
            <h2>
                Thảo Luận/Hỏi Đáp
            </h2>
            <m-button @click="openCreateForm" text="Thêm mới" type="primary-icon" className="btn-add"></m-button>
        </div>
        <div class="page__container">
            <div class="row align-center space-between">
                <!-- <div class="m-textfield">
                    <div class="m-input-container">
                        <input type="text" placeholder="">
                        <i class="fas fa-search"></i>
                    </div>
                </div> -->
                <m-textfield></m-textfield>
                <m-button text="" type="secondary" className="reload"></m-button>

            </div>
            <m-discuss v-for="(thread, index) in threads" :key="index" :ThreadTitle="thread.ThreadTitle"
                :ThreadType="thread.ThreadType" :UserName="thread.UserName" :AnswerNumber="thread.AnswerNumber"></m-discuss>
            <!-- <m-discuss :ThreadType="'question'" :ThreadTitle="'AAAAA'"></m-discuss> -->
        </div>
    </div>
    <DisscusForm v-if="form.isShow"></DisscusForm>
</template>
<script>
// import DiscussDetail from './DiscussDetail.vue';
import MDiscuss from './MDiscuss.vue';
export default {
    name: "DiscussList",
    components: {
        MDiscuss
    },
    created() {
        fetch('data/threads.json')
            .then((response) => response.json())
            .then((json) => console.log(json));
    },
    data() {
        return {
            threads: [
                {
                    "ThreadId": 1,
                    "ThreadTitle": "Cần giúp đỡ về việc sử dụng thuộc tính flex?",
                    "ThreadType": 1,
                    "UserName": "Nguyễn Văn Mạnh",
                    "AnswerNumber": 100,
                    "CreatedDate": "",
                    "ThreadContent": "",
                },
                {
                    "ThreadId": 2,
                    "ThreadTitle": "Có bao nhiêu cách để thực hiện layout website?",
                    "ThreadType": 1,
                    "UserName": "Đỗ Văn Cường",
                    "AnswerNumber": 8,
                    "CreatedDate": "",
                    "ThreadContent": "",
                },
                {
                    "ThreadId": 3,
                    "ThreadTitle": "Thảo luận về hiệu năng sử dụng các component có binding 2 chiều với nhiều thông tin.",
                    "ThreadType": 2,
                    "UserName": "Nguyễn Thị Nga",
                    "AnswerNumber": 12,
                    "CreatedDate": "",
                    "ThreadContent": "",
                },
                {
                    "ThreadId": 4,
                    "ThreadTitle": "Chia sẻ việc lập trình đồng bộ trong Javascript, những điều cần lưu ý.",
                    "ThreadType": 3,
                    "UserName": "Hoàng Ngọc Hân",
                    "AnswerNumber": 54,
                    "CreatedDate": "",
                    "ThreadContent": "",
                },
                {
                    "ThreadId": 5,
                    "ThreadTitle": "Cho em hỏi về đồ án tốt nghiệp tại trường ĐH Bách Khoa.",
                    "ThreadType": 1,
                    "UserName": "Trần Diễm Giang",
                    "AnswerNumber": 20,
                    "CreatedDate": "",
                    "ThreadContent": "",
                }
            ],
            form: {
                isShow: false,

            }
        }
    },
    methods: {
        openCreateForm() {
            this.form.isShow = true;

        }
    },
}
</script>
<style scoped>
.page__container {
    padding: 16px;
}

.thread-list {
    display: flex;
    flex-direction: column;
    margin-top: 10px;
}

.thread__icon {
    width: 40px;
    height: 40px;
    background-size: 40px;
    border-radius: 50%;
    flex: 0 0 40px;
    background-repeat: no-repeat;
    background-position: center;
}

.thread-item {
    display: flex;
    align-items: center;
    justify-content: flex-start;
    column-gap: 10px;
    padding: 10px 0;
}

.thread-item+.thread-item {
    border-top: 1px solid var(--border-color-default);
}

.thread-item__title {
    font-weight: 700;
    color: var(--color-primary);
}


.thread-item__info {
    display: flex;
    align-items: center;
    column-gap: 16px;
    margin-top: 4px;
    font-size: 12px;
}



.m-textfield {
    margin: unset;
}

.reload {
    width: 36px;
    background: url('../../assets/img/Sprites.64af8f61.svg') no-repeat -1090px -82px;
}

</style>