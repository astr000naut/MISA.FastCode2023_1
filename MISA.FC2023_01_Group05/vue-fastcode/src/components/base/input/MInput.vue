<template>
    <div class="field-text flex-y ">
        <label for="name-input">{{ label }}<span class="icon-require">*</span></label>
        <input type="text" @input="this.$emit('update:modelValue', $event.target.value)" id="name-input" class="field-input"
            name="name" />
    </div>
</template>

<script>
export default {
    name: "MInput",
    props: {
        label: {
            type: String,
        },
        modelValue: {

        }

    }
}
</script>

<style>
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





.input-name {
    margin-top: 0;
}
</style>