<template>
  <div class="redshoes-main">
    <header class="redshoes-header">
      <h1 class="redshoes-title">
        Contact Lydia Brown
      </h1>
    </header>
   
    <section class="redshoes-section contact-section">
      <!-- Contact Form -->
      <div class="redshoes-tile contact-form-tile">
        <h3 class="redshoes-tile-title">Contact Form</h3>
        <form @submit.prevent="submitForm" class="contact-form">
          <div class="form-column">
            <label class="redshoes-tile-desc" for="name">Name</label>
            <input id="name" v-model="form.name" type="text" placeholder="Enter your name" class="redshoes-input" />

            <label class="redshoes-tile-desc" for="email">Email</label>
            <input id="email" v-model="form.emailAddress" type="email" placeholder="Enter your email" class="redshoes-input" />

            <label class="redshoes-tile-desc" for="phone">Phone</label>
            <input id="phone" v-model="form.phoneNumber" type="tel" placeholder="Enter your phone number" class="redshoes-input" />

            <label class="redshoes-tile-desc" for="address">Location</label>
            <input id="address" v-model="form.address" type="text" placeholder="Enter your location" class="redshoes-input" />
          </div>
          <div class="form-column">
            <label class="redshoes-tile-desc" for="subject">Subject</label>
            <input id="subject" v-model="form.subject" type="text" placeholder="Type the subject" class="redshoes-input" />

            <label class="redshoes-tile-desc" for="message">Message</label>
            <textarea id="message" v-model="form.message" rows="7" placeholder="Type your message here..." class="redshoes-input"></textarea>

            <button type="submit" class="redshoes-btn-primary submit-btn">Submit</button>
          </div>
        </form>
      </div>
      
      <!-- Business Info -->
      <div class="redshoes-tile business-info-tile">
        <h3 class="redshoes-tile-title">Business Info</h3>
        <p class="redshoes-tile-desc contact-info">
          <b>Email:</b> <a href="mailto:info@lydiabrown.com.au">info@lydiabrown.com.au</a>
        </p>
        <p class="redshoes-tile-desc contact-info">
          <b>Phone:</b> <a href="tel:0">0</a>
        </p>
        <p class="redshoes-tile-desc contact-info">
          <b>Mail:</b> PO Box 1138, St Kilda South VIC 3182
        </p>
        <br>
        <a href="https://www.linkedin.com/in/lydiaabrown/" target="_blank" rel="noopener">
          <img src="https://cdn-icons-png.flaticon.com/512/174/174857.png" alt="Follow us on LinkedIn" class="linkedin-icon">
        </a>
        <br>
        <br>
        <p class="redshoes-tile-desc">
          <b>©2025 Lydia Brown.</b><br>
          Melbourne Victoria, Australia
        </p>
      </div>
    </section>

    <!-- Popup Box for Email Status -->
    <div v-if="showStatusBox" class="popup-overlay">
      <div class="popup-content">
        <button
          v-if="status === 'error' || status === 'success'"
          @click="showStatusBox = false"
          class="popup-close"
          aria-label="Close"
        >×</button>
        <div v-if="status === 'sending'">
          <span class="popup-text">Sending your message...</span>
        </div>
        <div v-else-if="status === 'success'">
          <span class="popup-text success">Your message has been sent!</span>
        </div>
        <div v-else-if="status === 'error'">
          <span class="popup-text error">
            Failed to send message.<br>
            Please email <br><b>info@lydiabrown.com.au</b> directly.
          </span>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { reactive, ref } from 'vue'

// Access in Vue component
const apiUrl = import.meta.env.VITE_API_BASE_URL
const apiKey = import.meta.env.VITE_API_KEY

const form = reactive({
  name: '',
  emailAddress: '',
  phoneNumber: '',
  address: '',
  subject: '',
  message: ''
})

const showStatusBox = ref(false)
const status = ref('sending')
let autoCloseTimeout = null

async function submitForm() {
  showStatusBox.value = true
  status.value = 'sending'
  try {
    const response = await fetch('/api/email', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
        'X-API-KEY': apiKey
      },
      body: JSON.stringify({
        name: form.name,
        emailAddress: form.emailAddress,
        phoneNumber: form.phoneNumber,
        subject: form.subject,
        message: form.message
      })
    })
    if (!response.ok) throw new Error('Failed to send')
    status.value = 'success'
    form.name = ''
    form.emailAddress = ''
    form.phoneNumber = ''
    form.address = ''
    form.subject = ''
    form.message = ''
    if (autoCloseTimeout) clearTimeout(autoCloseTimeout)
    autoCloseTimeout = setTimeout(() => {
      showStatusBox.value = false
    }, 3000)
  } catch (error) {
    status.value = 'error'
  }
}
</script>

