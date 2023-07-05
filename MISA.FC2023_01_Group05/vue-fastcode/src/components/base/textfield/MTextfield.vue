<template>
    <div class="m-textfield">
        <label for="">{{ label }}<strong class="text-red" v-if="isRequired"> *</strong></label>
        <div class="m-input-container">
            <input ref="input" :type="type" :placeholder="placeholder" :value="modelValue"
                @input="$emit('update:modelValue', $event.target.value)" :tabindex="tabindex">
        </div>
        <!-- <div class="message">

        </div> -->
    </div>
</template>
<script>
export default {
    name: 'MTextfield',
    props: {
        label: String,
        placeholder: String,
        type: String,
        modelValue: [String, Number, Date],
        tabindex: Number,
        isRequired: Boolean,
    },
    data() {
        return {
            errorMessage: "",

        }
    },
    methods: {
        focus() {
            this.$refs.input.focus();
        }
    },
}
</script>
<style scoped>
@import url(./textfield.css);
</style>