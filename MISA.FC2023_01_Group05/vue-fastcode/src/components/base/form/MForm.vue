<template>
    <div class="m-mask">
        <div class="form-container">
            <div class="form-title flex space-between align-center">
                <p>{{ formTitle }}</p>
                <span class="close text-danger" @click="closeForm">&times;</span>
            </div>

            <div class="form-input flex-y">
                <div class="field-text flex-y input-name ">
                    <m-input label="Họ và tên"></m-input>
                </div>

                <div class="field-text flex-y">
                    <m-input label="Email"></m-input>
                </div>
                <div class="field-text">
                    <label>Loại chủ đề<span class="icon-require">*</span></label>
                    <div class="radio-container flex">
                        <m-radio label="Hỏi đáp" nameProps="them-type"
                            :valueProps="this.$_MISAEnum.RADIO_VALUE.QANDA"></m-radio>
                        <m-radio label="Thảo luận" nameProps="them-type"
                            :valueProps="this.$_MISAEnum.RADIO_VALUE.DISCUSS"></m-radio>
                        <m-radio label="Chia sẻ" nameProps="them-type"
                            :valueProps="this.$_MISAEnum.RADIO_VALUE.SHARE"></m-radio>



                    </div>
                </div>

                <textarea rows="5" placeholder="Nhập nội dung" name="" id=""></textarea>
            </div>
            <div class="form-btn-group flex">
                <button class="btn form-btn-2" @click="closeForm">Huỷ</button>
                <button type="" class="btn form-btn-1">Đăng ký</button>
            </div>
        </div>
    </div>
</template>

<script>

export default {
    name: "MForm",
    props: {
        formTitle: {
            type: String,
        },
        formName: {
            type: String,
        },
        customPlaceholder: {
            type: String,
        },
    },
    data() {
        return {
            inValidErrors: [],

        }
    },
    methods: {
        closeForm() {
            this.$emit('closeForm')
        }
    },

}

</script>


<style scoped>
.form-container {
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    border-radius: var(--border-radius);
    width: 400px;
    border: 1px solid #c4c3c3;
    background-color: #fff;
}

p {
    margin: unset;
}

textarea {
    outline: unset;
    border: 1px solid #bbb;
    border-radius: var(--border-radius);
}

.form-title {
    font-size: 24px;
    font-weight: 700;
    padding: 24px 24px 12px 24px;
}

.close {
    cursor: pointer;
}



.form-input {
    margin: 0 24px 24px;
}

.icon-require {
    color: red
}

.field-text {
    margin-top: 16px;
}

.input-name {
    margin-top: 0;
}

.field-input {
    height: 36px;
    border-radius: 4px;
    border: 1px solid #E0E0E0;
    outline: none;
}

.field-input:focus {
    border-color: #50B83C;
}



.radio-input {
    margin-right: 24px;
    display: flex;
    align-items: center;
    justify-content: center;
}

.radio-input input {
    margin-right: 3px;
}

.form-btn-group {
    justify-content: end;
    padding: 24px 24px 24px 0;
    background-color: rgb(255, 255, 255);
}

.form-btn-2 {
    color: black;
    border: 1px solid rgb(161, 161, 161);
    margin-right: 8px;
}

.form-btn-2:hover {
    background-color: rgb(150, 150, 150);
}

.form-btn-1 {
    color: white;
    border: 1px solid rgb(161, 161, 161);
    margin-right: 8px;
    background-color: #50B83C;

}

.form-btn-1:hover {
    background-color: #51b83c7b;

}

.btn {
    font-family: Arial, Helvetica, sans-serif;
    height: 36px;
    border-radius: 4px;
    text-align: center;
    min-width: 80px;
}

/* @import 'bootstrap/dist/css/bootstrap.min.css'; */
</style>